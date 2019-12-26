const sql = require("./db.js");

// constructor
const loainuochoas = function(loainuochoas) {
  this.name = loainuochoas.name;
  this.image=loainuochoas.image;
  
};
loainuochoas.findById = (Id, result) => {
    sql.query(`SELECT * FROM loainuochoas WHERE id = ${Id}`, (err, res) => {
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


loainuochoas.getAll = result => {
  sql.query("SELECT * FROM loainuochoas", (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    console.log("loainuochoa: ", res);
    result(null, res);
  });
};


module.exports = loainuochoas;