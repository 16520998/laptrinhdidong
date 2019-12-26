const sql = require("./db.js");

// constructor
const Products = function(products) {
  this.name = products.name;
  this.id_loai = products.id_loai;
  this.gioitinh = products.gioitinh;
  this.description=products.description;
  this.unit_price=products.unit_price;
  this.image=products.image;
};

Products.create = (newProducts, result) => {
  sql.query("INSERT INTO products SET ?", newProducts, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(err, null);
      return;
    }

    console.log("created products: ", { id: res.insertId, ...newProducts });
    result(null, { id: res.insertId, ...newProducts });
  });
};
Products.gettheoloai = async (Id,result) => {
  sql.query(`SELECT p.id, p.name, p.gioitinh,p.description, p.unit_price, p.image FROM products p, loainuochoas l where p.id_loai = l.id and p.id_loai = ${Id} `, (err, res) => {
      if (err) {
          console.log("error: ", err);
          result(err, null);
          return;
        }
    
        if (res.length) {
          console.log("found products: ", res);
          result(null, res);
          return;
        }
    
        // not found Customer with the id
        result({ kind: "not_found" }, null);
      });
};

Products.findById = async (productsId, result) => {
  sql.query(`SELECT * FROM products WHERE id = ${productsId}`, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(err, null);
      return;
    }

    if (res.length) {
      console.log("found products: ", res[0]);
      result(null, res[0]);
      return;
    }

    // not found Customer with the id
    result({ kind: "not_found" }, null);
  });
};

Products.getAll = result => {
  sql.query("SELECT * FROM products", (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    console.log("products: ", res);
    result(null, res);
  });
};

Products.updateById = (id, products, result) => {
  sql.query(
    "UPDATE products SET  = ?, name = ?, id_loai = ?, gioitinh = ? , description = ? , unit_price = ? , image = ? WHERE id = ?",
    [products.name, products.id_loai, products.gioitinh,products.description,products.unit_price,products.image, id],
    (err, res) => {
      if (err) {
        console.log("error: ", err);
        result(null, err);
        return;
      }

      if (res.affectedRows == 0) {
        // not found Customer with the id
        result({ kind: "not_found" }, null);
        return;
      }

      console.log("updated Products: ", { id: id, ...products });
      result(null, { id: id, ...products });
    }
  );
};

Products.remove = (id, result) => {
  sql.query("DELETE FROM products WHERE id = ?", id, (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    if (res.affectedRows == 0) {
      // not found Customer with the id
      result({ kind: "not_found" }, null);
      return;
    }

    console.log("deleted products with id: ", id);
    result(null, res);
  });
};

Products.removeAll = result => {
  sql.query("DELETE FROM products", (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    console.log(`deleted ${res.affectedRows} products`);
    result(null, res);
  });
};

module.exports = Products;