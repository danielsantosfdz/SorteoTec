<link href="Content/Estilo.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sorteos TEC</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="Scripts/miJquery.js"></script>
 
</head>

<body>



    <form id="form1" >







        <div id="menu">
          <nav class="menu">
                <ul>
                    <li><a href="#">Sorteos Tec</a></li>
                    <li><a href="#">Ganadores</a></li>
                    <li><a href="#">Participar</a></li>
                </ul>
            </nav>
        </div>

        <br />
        <br />
        <div class="input-containerizq">
            <div>PARTICIPAR</div>
            <br />
            <div id="Cuerpo">Selecciona el número de participaciones.</div>
            <br />
            <div>Aseguráte que los datos de rotulación coincidan con los datos de tu identificación oficial</div>
        </div>


        <div class="input-container">
            <div class="inputs-top">
                <input type="text" id="nombre" name="nombre" placeholder="Nombre" style="display: inline-block; width: 150px;">

                <input type="email" id="correo" placeholder="Correo Electrónico" style="display: inline-block; width: 150px;">
            </div>


            <input type="text" id="telefono" placeholder="Teléfono" style="display: inline-block; width: 300px; margin-top: 10px; margin-left: 150px;">

            <br />
            <div class="selectOp" style="display: inline-block; width: 300px; margin-top: 10px; margin-left: 150px;">
                <select id="opcion" name="opcion">
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                    <option value="4">4</option>
                    <option value="5">5</option>
                    <option value="6">6</option>
                    <option value="7">7</option>
                    <option value="8">8</option>
                    <option value="9">9</option>
                    <option value="10">10</option>
                </select>
            </div>
            <br />
            <br />

            <div style="width: 150px; text-align: right; padding-right: 100px;">
                <button id="my-button" class="blue-button" >Pagar</button>
            </div>


        </div>
        <br />


    </form>
</body>

</html>



<footer class="footer">
    <p>Copyrigth © 2023, Sorteos Tec.</p>
</footer>
