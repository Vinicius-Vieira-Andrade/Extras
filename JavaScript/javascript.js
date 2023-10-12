let jogos = [];
let listaJogos = [];

jogos.push('Gta VI');
jogos.push('Minecraft 2');

console.log(jogos);

let resident4 = { Nome: "Resident Evil 4", Descricao: "Em Resident Evil 4 Remake, seis anos se passaram desde o desastre biológico em Raccoon City. O agente Leon S. Kennedy, um dos sobreviventes do incidente, foi enviado para resgatar a filha raptada do presidente. Ele segue o rastro dela até uma isolada vila europeia, onde há algo terrivelmente errado com os habitantes.", DataLancamento: "23/03/23", Preco: 259.00 };


console.log(resident4);


resident4.protagonista = "Leon S. Kennedy";

console.log(resident4);



let EldenRing = new Object();

EldenRing.Nome = "Elden Ring"
EldenRing.Descricao = "Em Elden Ring, o jogador incorpora um Maculado, guerreiro guiado pela força da Graça para portar o poder do Anel Prístino e torna-se um Lorde Prístino. A trama tem como cenário as Terras Intermédias, um local governado pela Rainha Marika.";
EldenRing.DataDeLancamento = "25/02/22";
EldenRing.Valor = 299.00;
console.log(EldenRing);


let Sekiro = new Object();

Sekiro.Nome = "Sekiro: Shadows Die Twice";
Sekiro.Descricao = "O jogo se passa em uma versão mágica e fictícia do período Sengoku no Japão, e segue um shinobi que tenta se vingar de um clã samurai que o atacou e sequestrou seu lorde. A jogabilidade é focada em furtividade, exploração e combate, com ênfase especial em batalhas contra chefes.";
Sekiro.DataDeLancamento = "22/03/19";
Sekiro.Valor = 199.00;


jogos.push(EldenRing);
console.log(jogos);

console.log();
console.log();

listaJogos.push(resident4);
listaJogos.push(EldenRing);
listaJogos.push(Sekiro);

console.log(listaJogos);

listaJogos.forEach((jogos, index) => {
    console.log(`${index + 1}º jogo: ${jogos.Nome}`);
});

for (let index = 0; index < listaJogos.length; index++) {
   console.log(`Jogo ${index + 1} : ${listaJogos[index].Nome}`);
};

