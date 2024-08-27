# Trade-offs de Características de Qualidade

As categorias de requisitos não-funcionais para o produto de software "Timely", conforme o modelo FURPS+, seriam:

1. **Usabilidade**: 
   
   a. Interfaces intuitivas e amigáveis para atender usuários de diferentes níveis de experiência.

   b. Fluxos de navegação simples e claros, especialmente para as funcionalidades críticas.

   c. Feedback visual e mensagens de erro claras e informativas.

   d. Considerar acessibilidade para usuários com deficiência.

2. **Desempenho**: 
   
   a. Tempo de resposta rápido para as funcionalidades críticas (criação de conta, login, recuperação de senha e salvar textos).

   b. Carregamento eficiente de listas de tarefas e eventos, mesmo com grande volume de dados.

3. **Confiabilidade**: 
   
   a. Segurança robusta para proteger dados de usuários, especialmente senhas e informações pessoais.
   
   b. Tratamento de erros eficiente para evitar falhas e interrupções.

4. **Suportabilidade**: 
   
   a. Código modular e bem documentado para facilitar a manutenção e futuras atualizações.

   b. 

A importância relativa de cada categoria:

| Categoria | Usabilidade | Desempenho | Confiabilidade | Suportabilidade |
| --- | --- | --- | --- | --- |
| Usabilidade | - | > | = | > |
| Desempenho | < | - | < | > |
| Confiabilidade | = | > | - | > |
| Suportabilidade | < | < | < | - |

> Nesta matriz, o sinal ">" indica que a categoria da linha é mais importante que a categoria da coluna, e o sinal "<" indica que a categoria da linha é menos importante que a categoria da coluna. Por exemplo, a Usabilidade é considerada mais importante que o Desempenho, Confiabilidade e Suportabilidade, enquanto o Desempenho é considerado mais importante que a Suportabilidade, mas menos importante que a Usabilidade e Confiabilidade, e assim por diante.

[Retorna](../README.md)
