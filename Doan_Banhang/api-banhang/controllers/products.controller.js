const Products = require("../models/products.model.js");

// Create and Save a new products
exports.create = (req, res) => {
    // Validate request
    if (!req.body) {
        res.status(400).send({
          message: "Content can not be empty!"
        });
      }
    
      // Create a Customer
      const products = function(products) {
        this.name = products.name;
        this.id_loai = products.id_loai;
        this.gioitinh = products.gioitinh;
        this.description=products.description;
        this.unit_price=products.unit_price;
        this.image=products.image;
      };
    
      // Save Customer in the database
      Products.create(products, (err, data) => {
        if (err)
          res.status(500).send({
            message:
              err.message || "Some error occurred while creating the Customer."
          });
        else res.send(data);
      });
    };


// Retrieve all products from the database.
exports.findAll = (req, res) => {
    Products.getAll((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while retrieving products."
        });
      else res.send(data);
    });
  };
  exports.gettheoloai = (req, res) => {
    Products.gettheoloai(req.params.Id, (err, data) => {
        if (err) {
          if (err.kind === "not_found") {
            res.status(404).send({
              message: `Not found Products with id loại ${req.params.Id}.`
            });
          } else {
            res.status(500).send({
              message: "Error retrieving Products with id " + req.params.Id
            });
          }
        } else res.send(data);
      });
};
// Find a single products with a productsId
exports.findOne = (req, res) => {
    Products.findById(req.params.productsId, (err, data) => {
        if (err) {
          if (err.kind === "not_found") {
            res.status(404).send({
              message: `Not found Products with id ${req.params.productsId}.`
            });
          } else {
            res.status(500).send({
              message: "Error retrieving Products with id " + req.params.productsId
            });
          }
        } else res.send(data);
      });
};

// Update a products identified by the productsId in the request
exports.update = (req, res) => {
  
};

// Delete a products with the specified productsId in the request
exports.delete = (req, res) => {
  
};

// Delete all products from the database.
exports.deleteAll = (req, res) => {
  
};