module.exports = app => {
    const Users = require("../controllers/users.controller");
    const bodyParser = require("body-parser");
    
    app.get("/users/Register",Users.findAll);

    app.post("/users/Register",Users.Register);
    app.post("/users/login",Users.Login);
}