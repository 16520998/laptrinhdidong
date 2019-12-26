const Loainuochoas = require("../models/loainuochoa.model");

// Create and Save a new products
exports.create = (req, res) => {
    // Validate request
    if (!req.body) {
        res.status(400).send({
          message: "Content can not be empty!"
        });
      }
    
      // Create a Customer
      const loainuochoas = function(loainuochoas) {
        this.name = loainuochoas.name;
        
      };
    
      // Save Customer in the database
      Loainuochoas.create(loainuochoas, (err, data) => {
        if (err)
          res.status(500).send({
            message:
              err.message || "Some error occurred while creating the loainuochoas."
          });
        else res.send(data);
      });
    };


// Retrieve all products from the database.
exports.findAll = (req, res) => {
    Loainuochoas.getAll((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while retrieving loainuochoas."
        });
      else res.send(data);
    });
  };
  

// Find a single products with a productsId

  
