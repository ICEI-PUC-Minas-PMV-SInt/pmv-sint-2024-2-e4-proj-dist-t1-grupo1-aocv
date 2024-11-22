**Construir uma imagem Docker a partir do Dockerfile e arquivos no diretório atual.**
```bash
docker build . -t timely
```

---
O comando `docker run -p 9090:5000 -e ASPNETCORE_ENVIRONMENT=Development timely --name timely` é usado para executar um container a partir de uma imagem Docker chamada `timely` e configurá-lo com algumas opções específicas. Vamos detalhar o que cada parte do comando faz:

1. **`docker run`**: Este comando inicia um novo container a partir de uma imagem Docker especificada.

2. **`-p 9090:5000`**: A opção `-p` faz o mapeamento de portas entre o host e o container.
   - **`9090:5000`** significa que a porta **5000** dentro do container (onde a aplicação está escutando) será mapeada para a porta **9090** do host. Ou seja, ao acessar `http://localhost:9090` no seu navegador ou em algum cliente, você estará se conectando à porta 5000 dentro do container.

3. **`-e ASPNETCORE_ENVIRONMENT=Development`**: A opção `-e` define variáveis de ambiente no container. 
   - **`ASPNETCORE_ENVIRONMENT=Development`** define a variável de ambiente `ASPNETCORE_ENVIRONMENT` como `Development`. Isso é frequentemente usado para configurar o ambiente de execução de uma aplicação .NET Core, dizendo à aplicação que ela deve ser executada no modo de desenvolvimento, o que pode ativar comportamentos específicos para esse modo (como mensagens de erro detalhadas ou configurações de depuração).

4. **`timely`**: Este é o nome da imagem Docker que será usada para criar o container. A imagem `timely` será buscada no repositório local (se já estiver disponível) ou no Docker Hub (se não estiver localmente).

5. **`--name timely`**: A opção `--name` define um nome para o container em execução. Neste caso, o container será nomeado `timely`. Isso facilita a identificação e manipulação do container (como parar, iniciar ou visualizar logs) usando esse nome em vez de usar o ID do container.

### Resumo:
Esse comando vai rodar um container a partir da imagem `timely`, mapeando a porta 5000 do container para a porta 9090 do host, definindo a variável de ambiente `ASPNETCORE_ENVIRONMENT` como `Development` para a aplicação dentro do container, e nomeando o container como `timely`.

```bash
docker run -p 9090:5000 -e ASPNETCORE_ENVIRONMENT=Development timely --name timely
```
