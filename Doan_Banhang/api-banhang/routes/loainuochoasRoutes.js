module.exports = app => {
    const loainuochoas = require("../controllers/loainuochoas.controller");
    
    // Create a new Customer
    //app.post("/products", products.create);
  
    // Retrieve all Customers
    app.get("/loainuochoas", loainuochoas.findAll);

    // Retrieve a single Customer with customerId
    //app.get("/loainuochoas/:loainuochoasId", loainuochoas.findOne);
  
    // Update a Customer with customerId
   // app.put("/products/:/productsId", products.update);
  
    // Delete a Customer with customerId
    //app.delete("/products/:productsId", products.delete);
  
    // Create a new Customer
   // app.delete("/products", products.deleteAll);
  };