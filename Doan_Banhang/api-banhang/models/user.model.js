const sql = require("./db.js");

// constructor

// Users.register:async (req,res)=>{

// }
const Users = function(users) {
  this.full_name = users.full_name;
  this.email = users.email;
  this.password = users.password;
  this.phone=users.phone;
  this.address=users.address;
  this.created_at=users.created_at
};
//+"'&& password='"+password+"'
Users.Login=async (email,password,result)=>{
  
    await sql.query('SELECT * FROM users WHERE email = ?',[email], function (error, res, data) {
    if (error) {
        res.json({
          status:false,
          message:'there are some error with query'
          })
    }else{
     
      if(data.length >0){

          if(password==data[0].password){
              res.json({
                  status:true,
                  message:'successfully login'
              })
          }else{
              res.json({
                status:false,
                message:"Email and password does not match"
               });
          }
        
      }
      else{
        res.json({
            status:false,    
          message:"Email does not exits"
        });
      }
    }
  });

  }

Users.Register=(newusers,result)=>{
  
        sql.query("INSERT INTO users SET ?", newusers, (err, res) => {
        if (err) {
  
          console.log("error: ", err);
          result(err, null);
          return;
        }
        else
        {
                  console.log("created users: ", { id: res.insertId, ...newusers });
                    // res.send({"code":200,
                    // "success":"user registered sucessfully"});
                    console.log("user registered sucessfully")
                }
        return result(null, { id: res.insertId, ...newusers });
      });
    }
// };
// })};
   


Users.getAll = result => {
  sql.query("SELECT * FROM users ", (err, res) => {
    if (err) {
      console.log("error: ", err);
      result(null, err);
      return;
    }

    console.log("users: ", res);
    result(null, res);
  });
};


module.exports = Users;