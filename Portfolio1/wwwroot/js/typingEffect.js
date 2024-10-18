const text = "Bem-vindo ao meu Portfólio";
let index = 0;

function type() {
    if (index < text.length) {
        document.getElementById("typingEffect").textContent += text.charAt(index);
        index++;
        setTimeout(type, 100);
    } else {
        document.getElementById("cursor").style.display = "inline-block";
    }
}

window.onload = function () {
    type(); // inicia o efeito ao carregar a página
    document.getElementById("cursor").style.display = "inline";
};
