# desafio-grandes-arquivos
[![wakatime](https://wakatime.com/badge/user/823f342c-95fe-455c-9ac0-5495d0cfc31b/project/5ae24f91-e041-4813-8210-85e7f70f943a.svg)](https://wakatime.com/badge/user/823f342c-95fe-455c-9ac0-5495d0cfc31b/project/5ae24f91-e041-4813-8210-85e7f70f943a)

### Tecnologias utilizadas
* .NET 6
* DOCKER

### Desafio
[Link - desafio processando arquivos grandes com restrição de memoria](https://dev.to/zanfranceschi/desafio-processar-arquivos-grandes-com-restricao-de-memoria-2ie3)
> Ei dev,
Aceita um desafio pra lidar com restrição de memória?
>-   Gere um arquivo várias linhas com cerca de 100MB de tamanho;
>-   Faça um programa que leia esse arquivo e printe o resultado como na imagem;
>-   Dockerize ele e o execute com limite de memória de 20m;

### Como Rodar o Projeto

    docker build -t desafio-mem-app -f Dockerfile .
    docker run --memory="20m" desafio-mem-app
    

