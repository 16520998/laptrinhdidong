const Users = require("../models/user.model.js");
const sql = require("../models/db");



// Create and Save a new products
exports.Register = async(req, res)=>{
    var today=new Date();
    const body=req.body;
    var full_name=body.full_name;
    var email=body.email;
    var password=body.password;
    var phone=body.phone;
    var address=body.address
        var users= {
       
        "full_name":full_name,
        "email":email,
        "password":password,
        "phone":phone,
        "address":address,
        "created_at":today
      }
     Users.Register(users,(err,results)=>{
       if(err){
         console.log(err);
         return res.status(400).json({
           success:0,
           message:err.sqlMessage
         })
       }
       return res.status(200).json({
         
         success:"user registered sucessfully"
       });
     })
      console.log(req.body+"dưankjsd");
 }
 exports.Login = async(req, res)=>{
  const body=req.body;
  var email=body.email;
  var password=body.password; 
  console.log(email+"và "+password);
 await sql.query('SELECT * FROM users WHERE email = ?',[email], function (error, results, fields) {
    if (error) {
        res.json({
          status:false,
          message:'there are some error with query'
          })
    }else{
     
      if(results.length >0){

          if(password==results[0].password){
              res.json({
                  status:true,
                  message:'successfully Login!'
              })
          }else{
            res.status(400).json({
              status:false,
                message:"Password wrong!"
               });
          }
        
      }
      else{
        res.json({
            status:400,    
          message:"Email does not exits"
        });
      }
    }
  });
 
  
      
 }

// Retrieve all products from the database.
exports.findAll = (req, res) => {
    Users.getAll((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while retrieving products."
        });
      else res.send(data);
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