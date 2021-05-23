const express = require('express');
const app = express();
const port = 3000;
const admin = require("firebase-admin");

var serviceAccount = require("D:/MapAPI/Member_Tri/Cloud_Firestore/fir-data-610d2-firebase-adminsdk-49dvb-b7ae9142f7.json");

admin.initializeApp({
  credential: admin.credential.cert(serviceAccount),
  databaseURL: "https://fir-data-610d2-default-rtdb.firebaseio.com"
});


app.use(express.json());
app.use(express.static('public'));

app.get('/',(req,res) => {
    res.send('index2');
})