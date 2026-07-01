let paises = [
    {
        nombre: "El Salvador",
        continente: "América del Centro",
        capital: "San Salvador",
        extension: "21,041 km²"
    },

    {
        nombre: "Argentina",
        continente: "América del Sur",
        capital: "Buenos Aires",
        extension: "2,780,400 km²"
    },
    {
        nombre: "Japón",
        continente: "Asia",
        capital: "Tokio",
        extension: "377,975 km²"
    },
    {
        nombre: "Francia",
        continente: "Europa",
        capital: "París",
        extension: "551,695 km²"
    },
    
    {
        nombre: "Colombia",
        continente: "América del Sur",
        capital: "Bogotá",
        extension: "1,141,748 km²"
    }
];

const tablaPaises = document.getElementById("tablaPaises");

const txtNombre = document.getElementById("txtNombre");
const txtContinente = document.getElementById("txtContinente");
const txtCapital = document.getElementById("txtCapital");
const txtExtension = document.getElementById("txtExtension");
const btnAgregar = document.getElementById("btnAgregar");


function mostrarPaises() {
    tablaPaises.innerHTML = ""; 

    paises.forEach((pais) => {
        tablaPaises.innerHTML += `
        <tr>
             <td>${pais.nombre}</td>
             <td>${pais.continente}</td>
             <td>${pais.capital}</td>
             <td>${pais.extension}</td>
        </tr>
        `;
    });
}

function agregarPais() {
    if (txtNombre.value.trim() === "" || txtContinente.value.trim() === "" || txtCapital.value.trim() === "" || txtExtension.value.trim() === "") {
        alert("Por favor, complete todos los campos del formulario.");
        return;
    }

    const nuevoPais = {
        nombre: txtNombre.value,
        continente: txtContinente.value,
        capital: txtCapital.value,
        extension: txtExtension.value
    };

    paises.push(nuevoPais);

    mostrarPaises();

    txtNombre.value = "";
    txtContinente.value = "";
    txtCapital.value = "";
    txtExtension.value = "";
}


mostrarPaises();

btnAgregar.addEventListener("click", agregarPais);