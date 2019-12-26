const Billdetail = require("../models/bill_detail.model.js");




// Create and Save a new products
exports.Create = async(req, res)=>{
    //var today=new Date();
    const body=req.body;
    var tensanpham=body.tensanpham;
    var quantity=body.quantity;
    var Total=body.Total;
    var customer=body.customer;
    var Note=body.Note;
    console.log(tensanpham+"dnwkand");
    var billdetail= {
        "tensanpham":tensanpham,
        "quantity":quantity,
        "Total":Total,
        "customer":customer,
        "Note":Note
      }
    
     Billdetail.Create(billdetail,(err,results)=>{
       if(err){
         console.log(err);
         return res.status(500).json({
           success:0,
           message:err.sqlMessage
         })
       }
       return res.status(200).json({
         
         success:"bill create sucessfully!"
       });
     })
     
      
      
          
    
 }

      


// Retrieve all products from the database.
exports.findAll = (req, res) => {
    Billdetail.getAll((err, data) => {
      if (err)
        res.status(500).send({
          message:
            err.message || "Some error occurred while retrieving bill:(("
        });
      else res.send(data);
    });
  };
  