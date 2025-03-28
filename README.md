# Projeto A4 Jogos

## 🔧 Requisítos Técnicos

Certifiquesse de que você possui os seguintes programas instalados para poder usar e contribuir para o projeto:

* [Git](https://git-scm.com/downloads) (Usado no versionamento do projeto)
* [VSCode](https://code.visualstudio.com/) (Editor de texto usado para desenvolvimento)
* [Unity](https://unity.com/) (Editor de desenvolvimento de jogo)


## 🚀 Como Configurar o Ambiente
Primeira vez no repositório? Siga os passos abaixo:

1. Abra o terminal e acesse a pasta em que deseja colocar o projeto.
2. Execute o seguinte comando para clonar o projeto para o seu computador:
```
git clone https://github.com/ViniciusALS/ProjetoA4Jogos.git
```
3. Abra o arquivo pelo [VSCode](https://code.visualstudio.com/).


## 🔄 Fluxo de Trabalho com Git

### Primeira Vez Usando Git

Se essa for a sua primeira vez usando o git, você tera de fazer algumas configurações.

1. Abra o terminal
2. Execute os seguintes comandos

```
git config --global user.name "seuNomeDeUsuario"
```
```
git config --global user.email "meu_email@email.com"
```

### Como Puxar Atualizações

Sempre que quiser puxar as modificações do código na núvem de outros colaboradores:

1. Abra o terminal e certifique-se de que está no diretório do projeto.
2. Execute o comando:

```
git pull
```

### Como Enviar Atualizações

Sempre que quiser enviar suas modificações no código para a núvem:

Antes, garanta que nenhum outro membro fez outra modificação no mesmo arquivo.

```
git pull
git status  
```

Após garantir que nenhum outro colaborador fez outra modificação no mesmo arquivo:

```
git add .
git commit -m "Comentário sobre a alteração"
git push origin main
```