const express = require('express');

const app = express();

const PORT = 3000;



app.get('/', (req, res) => {

  res.send('¡Bienvenido a SoloClick Web Server!');

});



app.listen(PORT, () => {

  console.log(`Servidor corriendo en http://localhost:${PORT}`);

});
