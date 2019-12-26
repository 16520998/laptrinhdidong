module.exports = app => {
    const Billdetail = require("../controllers/bill_detail.controller");
    const bodyParser = require("body-parser");
    
    app.get("/bill",Billdetail.findAll);

    app.post("/bill",Billdetail.Create);
}