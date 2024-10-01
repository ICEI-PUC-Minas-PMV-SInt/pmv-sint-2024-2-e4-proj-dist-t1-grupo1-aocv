# Diagrama de Contêiner

> O diagrama de contêiner usando a notação C4 mostra de forma clara e detalhada como nosso sistema é estruturado. Ele explica como as responsabilidades são divididas e como cada parte se comunica para proporcionar uma experiência tranquila e eficaz ao usuário, no caso, nosso querido advogado Renan Thiago Alexandre Lima.

# Cliente (Aplicativo Móvel/Web)
- Interface do Usuário: Aqui é onde tudo começa. Renan pode acessar suas tarefas, usar o cronômetro Pomodoro e ver relatórios de produtividade. Tudo na palma da mão, fácil e intuitivo.

Formulário de Entrada de Tarefas: Renan insere novas tarefas e as organiza conforme sua necessidade, tudo de forma prática.

Cronômetro Pomodoro: Integrado diretamente na interface, ajuda Renan a focar nas suas atividades em blocos de tempo com pausas, melhorando a concentração e evitando a fadiga mental.

Relatórios de Produtividade: Mostra relatórios detalhados para que Renan saiba exatamente como está utilizando seu tempo e onde pode melhorar.

# Servidor (Backend)
API Gateway: O ponto de entrada central para todas as solicitações do cliente. Como uma central de distribuição que garante que tudo vai para o lugar certo.

Serviço de Autenticação: Gerencia quem está entrando e garantindo que apenas Renan (e outros usuários) possam acessar suas informações.

Serviço de Tarefas: Cuida da criação, leitura, atualização e exclusão das tarefas de Renan.

Serviço de Notificações: Envia alertas para Renan sobre suas tarefas e prazos, ajudando-o a manter tudo em dia.

Serviço de Google Calendar: Sincroniza as tarefas com o Google Calendar de Renan, garantindo que todas as atividades estejam centralizadas.

Serviço de Produtividade: Gera relatórios e análises baseadas nos dados de produtividade de Renan, oferecendo insights valiosos para que ele possa gerenciar melhor seu tempo.

# Banco de Dados
Banco de Dados de Usuários: Guarda as informações de todos os usuários, como dados de login e preferências.

Banco de Dados de Tarefas: Armazena todas as tarefas criadas, com detalhes sobre prazos, prioridades e estados de conclusão.

Banco de Dados de Produtividade: Contém os dados relacionados à produtividade dos usuários, que alimentam os relatórios e análises.

# Integrações Externas
API do Google Calendar: Permite que as tarefas sejam sincronizadas com o Google Calendar de Renan, garantindo que ele não perca nada.

Serviço de Notificações Externas: Envia notificações para Renan através de serviços externos, lembrando-o de eventos e prazos importantes.

# Como tudo se conecta
Cliente para Servidor: A interface do usuário envia solicitações ao API Gateway para criar, ler, atualizar ou deletar tarefas.

Servidor para Banco de Dados: Os serviços no backend interagem com os bancos de dados para armazenar e recuperar informações conforme necessário.

Servidor para Integrações Externas: O Serviço de Notificações e o Serviço de Google Calendar fazem chamadas para APIs externas para enviar notificações e sincronizar tarefas, respectivamente.

Servidor para Cliente: O servidor responde ao cliente com os dados necessários, atualizando a interface do usuário em tempo real.

Este diagrama mostra como todas as partes da aplicação trabalham juntas para proporcionar uma experiência eficiente e integrada para Renan, ajudando-o a gerenciar suas tarefas e melhorar sua produtividade.

![Untitled diagram-2024-09-30-234214](https://github.com/user-attachments/assets/bea5a869-6bad-4098-b381-9428f35dc64f)

