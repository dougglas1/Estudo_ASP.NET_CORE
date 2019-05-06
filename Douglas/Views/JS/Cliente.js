let Nome = document.getElementById('Nome');
let Genero = document.getElementById('Genero');
let Data_Nascimento = document.getElementById('Data_Nascimento');
let Telefone = document.getElementById('Telefone');
let Button = document.getElementById('Button');

Button.addEventListener('click', () => {
    let xhr = new XMLHttpRequest();
    xhr.open("POST", "api/Cliente/Inserir", true); // PRECISO PASSAR COMO OBJETO CLIENTE

    xhr.onreadystatechange = () => {
        if (xhr.readyState === XMLHttpRequest.DONE && xhr.status === 200) {
            console.log(xhr.responseText);
        }
    }
    xhr.send();
})