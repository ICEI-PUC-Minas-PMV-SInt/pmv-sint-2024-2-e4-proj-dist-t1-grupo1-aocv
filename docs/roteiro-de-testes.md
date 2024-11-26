# Roteiro de Teste

## **Objetivo**
Verificar o correto funcionamento das funcionalidades do sistema, incluindo backend e frontend, garantindo que todos os componentes estejam integrados e operacionais.

---

## **1. Testes de Backend**

### **1.1 Configuração do Banco de Dados**
**Objetivo**: Validar se a conexão com o banco de dados relacional está configurada corretamente.

1. Iniciar a aplicação backend.
2. Verificar se as tabelas são criadas automaticamente ao aplicar `dotnet ef database update`.
3. Inserir dados de teste diretamente no banco e validar o acesso via API.

**Resultado Esperado**:  
O banco de dados deve ser acessado corretamente, com tabelas criadas e acessíveis.

---

### **1.2 Testes de Endpoints REST**
**Objetivo**: Garantir que os endpoints da API estão funcionando conforme especificado.

| **Endpoint**         | **Método** | **Teste**                                 | **Resultado Esperado**                    |
|-----------------------|------------|-------------------------------------------|-------------------------------------------|
| `/api/resource`       | GET        | Consultar todos os recursos.              | Retornar a lista de recursos.             |
| `/api/resource/{id}`  | GET        | Consultar recurso específico por ID.      | Retornar o recurso correspondente.        |
| `/api/resource`       | POST       | Criar um novo recurso.                    | Adicionar e retornar o recurso criado.    |
| `/api/resource/{id}`  | PUT        | Atualizar recurso específico.             | Modificar os dados corretamente.          |
| `/api/resource/{id}`  | DELETE     | Deletar recurso específico.               | Remover o recurso do banco de dados.      |

**Passos**:
1. Utilizar ferramentas como *Postman* ou *Insomnia* para testar os endpoints.
2. Enviar requisições válidas e inválidas.

**Resultado Esperado**:  
A API deve retornar respostas corretas, incluindo mensagens de erro para dados inválidos.

---

### **1.3 Testes Unitários**
**Objetivo**: Garantir que a lógica do backend está funcionando corretamente.

- **Ferramenta**: xUnit.
- Executar os testes com:
  ```bash
  dotnet test
## Roteiro de Teste

---

### 2. feat: adiciona testes para validação de endpoints REST no backend

**Descrição:**
- Testes realizados para garantir o funcionamento correto dos endpoints REST.
- Incluem operações de criação, consulta, atualização e exclusão de recursos.
- Ferramenta utilizada: Postman/Insomnia para testes manuais de rotas.

---

### 3. test: adiciona testes unitários com xUnit no backend

**Descrição:**
- Configuração do ambiente de testes utilizando xUnit.
- Testes de unidade criados para validar lógica de negócios, controladores e repositórios.
- Testes executados com o comando `dotnet test`.

---

### 4. feat: adiciona integração do frontend com a API REST

**Descrição:**
- Configuração de serviços para comunicação com o backend utilizando Axios.
- Validação da exibição de dados do backend na interface do usuário.
- Testes manuais realizados para verificar fluxos de navegação e integração com a API.

---

### 5. test: implementa testes automatizados com Jest no frontend

**Descrição:**
- Configuração do ambiente de testes utilizando Jest.
- Testes unitários criados para componentes reutilizáveis (ex.: botões, formulários).
- Testes de integração desenvolvidos para fluxos de interface e consumo de dados da API.

---

### 6. test: adiciona testes de integração frontend ↔ backend ↔ banco de dados

**Descrição:**
- Fluxos completos testados, desde a interface até o banco de dados.
- Testes validam que as operações CRUD realizadas no frontend são refletidas no banco de dados.
- Incluem verificação de consistência e recuperação de dados.

---

### 7. test: realiza testes de desempenho no backend

**Descrição:**
- Configuração de testes de carga no backend utilizando ferramentas como Apache Benchmark ou JMeter.
- Simulação de requisições simultâneas para avaliar tempo de resposta e estabilidade do sistema.

---

### 8. test: realiza testes de desempenho no frontend

**Descrição:**
- Avaliação de desempenho do frontend utilizando Lighthouse.
- Otimização para melhorar pontuações de desempenho, acessibilidade e SEO.

---

### 9. test: adiciona testes de segurança ao backend

**Descrição:**
- Validação de segurança para endpoints utilizando ferramentas de análise estática e dinâmica.
- Testes incluem:
  - Proteção contra SQL Injection.
  - Configuração de CORS para prevenir acesso não autorizado.
  - Validação de autenticação e autorização.

---

### 10. test: implementa testes de segurança no frontend

**Descrição:**
- Verificação de segurança no consumo de APIs.
- Testes de validação para manipulação correta de dados sensíveis.
- Análise de dependências do projeto com ferramentas como `npm audit`.

---

### 11. test: valida ambiente de produção após deploy

**Descrição:**
- Realizados testes finais no ambiente de produção para validar:
  - Funcionamento do frontend hospedado.
  - Comunicação correta entre frontend e backend.
  - Banco de dados operacional.
- Incluem simulação de cenários reais para validar a estabilidade do sistema.

