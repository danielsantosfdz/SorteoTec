
$(document).ready(function () {
    var nombreValido = false;
    var correoValido = false;
    var telefonoValido = false;

    $('#nombre').on('keypress', function (e) {
      
        var codigoTecla = e.which;

        // Si el código ASCII es un número (entre 48 y 57)
        if (codigoTecla >= 48 && codigoTecla <= 57) {
            // Previene que se ingrese el número en el input
            nombreValido = false;
            alert("El campo no permite números");
            e.preventDefault();
        }
        else {

            nombreValido = true;
            //validarCampos();
}
    });


    $('#correo').on('blur', function () {
        // Obtiene el valor del input de correo electrónico
        var correo = $(this).val();

        // Define la expresión regular para validar el correo electrónico
        var patronCorreo = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        // Verifica si el valor ingresado coincide con el patrón de correo electrónico
        if (!patronCorreo.test(correo)) {
            correoValido = false;
            alert('El correo electrónico es inválido.');
        } else {
            correoValido = true;
            //validarCampos();
        }
    });




    $('#telefono').on('blur', function () {
        // Obtiene el valor del input de teléfono
        var telefono = $(this).val();

        // Elimina todos los caracteres que no sean números
        telefono = telefono.replace(/[^\d]/g, '');

        // Verifica si el valor ingresado tiene una longitud de 10 caracteres
        if (telefono.length !== 10) {
            telefonoValido = false;
            alert('El telefono debe ser de longitud 10.');
        } else {

            telefonoValido = true;
            //validarCampos();
}
    });



 

        $("#my-button").click(function () {
            $.ajax({
                url: "https://jsonplaceholder.typicode.com/posts",
                type: "POST",
                data: {
                    title: "Título del post",
                    body: "Cuerpo del post",
                    userId: 1
                },
                success: function (result) {
                    console.log(result);
                    alert(result);
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    console.log(thrownError);
                }
            });
                });



    //document.getElementById('my-button').addEventListener('click', obtenerDatos);

    /*function obtenerDatos() {

        fetch('https://jsonplaceholder.typicode.com/todos/1')
            .then(response => response.json())
            .then(data => console.log(data))
            .catch(error => console.error(error));

        alert(data);
    }
    */

    //function validarCampos() {
    //    if (nombreValido && correoValido && telefonoValido) {
    //        $('#my-button').prop('disabled', false);
    //    } else {
    //        $('#my-button').prop('disabled', true);
    //    }
    //}

    //function obtenerDatos() {
    //    if (nombreValido && correoValido && telefonoValido) {
    //        alert("disable false");
    //    } else {
    //        alert("disable true");
    //    }
    //}

});





