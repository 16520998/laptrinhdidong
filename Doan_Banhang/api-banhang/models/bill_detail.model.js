const sql = require("./db.js");

// constructor

// Users.register:async (req,res)=>{

// }
const Billdetail = function(Billdetail) {
  this.tensanpham = Billdetail.tensanpham;
  this.quantity = Billdetail.quantity;
  this.Total = Billdetail.Total;
  this.customer=Billdetail.customer;
  this.Note=Billdetail.Note;
};
Billdetail.Create=(newbill,result)=>{
    
          sql.query("INSERT INTO bill_detail SET ?", newbill, (err, res) => {
          if (err) {
            
            console.log("error: ", err);
            result(err, null);
            return;
          }
          else
          {
                    console.log("created bill detais: ", { id: res.insertId, ...newbill });
                      // res.send({"code":200,
                      // "success":"user registered sucessfully"});
                      console.log("create sucessfully!")
                  }
          return result(null, { id: res.insertId, ...newbill });
        });
      }
Billdetail.getAll = result => {
        sql.query("SELECT * FROM bill_detail ", (err, res) => {
          if (err) {
            console.log("error: ", err);
            result(null, err);
            return;
          }  
          console.log("bill_detail: ", res);
          result(null, res);
        });
      };
      module.exports = Billdetail;      