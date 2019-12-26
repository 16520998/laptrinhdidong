module.exports = app => {
    const products = require("../controllers/products.controller.js");
  
    // Create a new Customer
    //app.post("/products", products.create);
  
    // Retrieve all Customers
    app.get("/products", products.findAll);
  
    // Retrieve a single Customer with customerId
    app.get("/products/:productsId", products.findOne);
  app.get("/products/gettheoloai/:Id",products.gettheoloai)
    // Update a Customer with customerId
   // app.put("/products/:/productsId", products.update);
  
    // Delete a Customer with customerId
    //app.delete("/products/:productsId", products.delete);
  
    // Create a new Customer
   // app.delete("/products", products.deleteAll);
  };