var btnCadastrar = document.querySelector("#Cadastrar");

btnCadastrar.addEventListener("click", function (event) {
    event.preventDefault();

    validarCadastro();
})

function validarCadastro() {

    var nome = $("#nome").val();
    var cpf = $("#cpf").val();
    var telefone = $("#telefone").val();
    var cep = $("#cep").val();
    var estado = $("#estado").val();
    var cidade = $("#cidade").val();
    var bairro = $("#bairro").val();
    var rua = $("#rua").val();
    var numero = $("#numero").val();
    var email = $("#email").val();
    var senha = $("#senha").val();
    var confirmarSenha = $("#confirmar-senha").val();

    // Nome
    // CPF
    // Telefone
    // CEP
    // Estado
    // Cidade
    // Bairro
    // Rua
    // Número


    // Email

    if (email === "") {
        alert("Email deve ser informado.");
    }
    else {
        if (RegExp.test(email)) {
            console.log(email);
        }
        else {
            console.log("Email inválido!");
        }
    }

    // Senha
    if (senha !== confirmarSenha) {
        console.log("Senhas diferentes.");
    } else {

    }
}