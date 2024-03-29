const express = require("express");
const bodyParser = require("body-parser");
const app = express();



// require("./routes/productsRoutes.js")(app);
// parse requests of content-type: application/json
app.use(bodyParser.json());

// parse requests of content-type: application/x-www-form-urlencoded

app.use(bodyParser.urlencoded({ extended: true }));

// simple route
app.get("/", (req, res) => {
  res.json({ message: "welcome my application." });
});


require("./routes/productsRoutes")(app);
require("./routes/loainuochoasRoutes")(app);
require("./routes/userRoutes")(app);
require("./routes/bill_detailRoutes")(app);
// set port, listen for requests
app.listen(3000, () => {
  console.log("Server is running on port 3000.");
});