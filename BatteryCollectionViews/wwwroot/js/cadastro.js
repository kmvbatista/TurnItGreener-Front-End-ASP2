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
    RegExp = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

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

function limpa_formulario_cep() {
    //Limpa valores do formulário de cep.
    document.getElementById('rua').value=("");
    document.getElementById('bairro').value=("");
    document.getElementById('cidade').value=("");
    document.getElementById('estado').value=("");
        
}

function meu_callback(conteudo) {
    if (!("erro" in conteudo)) {
        //Atualiza os campos com os valores.
        document.getElementById('rua').value=(conteudo.logradouro);
        document.getElementById('bairro').value=(conteudo.bairro);
        document.getElementById('cidade').value=(conteudo.localidade);
        document.getElementById('estado').value=(conteudo.uf);
    } //end if.
    else {
        //CEP não Encontrado.
        limpa_formulario_cep();
        alert("CEP não encontrado.");
        document.getElementById('cep').value=("");
    }
}
    
function pesquisacep(valor) {

    //Nova variável "cep" somente com dígitos.
    var cep = valor.replace(/\D/g, '');

    //Verifica se campo cep possui valor informado.
    if (cep !== "") {

        //Expressão regular para validar o CEP.
        var validacep = /^[0-9]{8}$/;

        //Valida o formato do CEP.
        if(validacep.test(cep)) {

            //Preenche os campos com "..." enquanto consulta webservice.
            document.getElementById('rua').value="...";
            document.getElementById('bairro').value="...";
            document.getElementById('cidade').value="...";
            document.getElementById('estado').value="...";

            //Cria um elemento javascript.
            var script = document.createElement('script');

            //Sincroniza com o callback.
            script.src = "https://viacep.com.br/ws/" + cep + "/json/?callback=meu_callback";

            //Insere script no documento e carrega o conteúdo.
            document.body.appendChild(script);

        } //end if.
        else {
            //cep é inválido.
            limpa_formulario_cep();
            alert("Formato de CEP inválido.");
        }
    } //end if.
    else {
        //cep sem valor, limpa formulário.
        limpa_formulario_cep();
    }
}