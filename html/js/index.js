const carrusel = document.querySelector('.carrusel');
const eventos = document.querySelectorAll('.evento');
const btnDer = document.getElementById('derecha');
const btnIzq = document.getElementById('izquierda');

let posicion = 0;

btnDer.addEventListener('click', () => {
  posicion = (posicion + 1) % eventos.length;
  actualizar();
});

btnIzq.addEventListener('click', () => {
  posicion = (posicion - 1 + eventos.length) % eventos.length;
  actualizar();
});

eventos.forEach(evento => {
  evento.addEventListener('click', () => {
    const url = evento.getAttribute('data-url');
    window.location.href = url;
  });
});

function actualizar() {
  carrusel.style.transform = `translateX(-${posicion * 100}%)`;
}