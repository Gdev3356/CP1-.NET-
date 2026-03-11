# Contra-Filé - Uma API para serviço de restaurante!

- Criada por Gustavo Keiji Okada, RM563428

- Baseado em sistemas de restaurantes

**Entidades Modeladas**

- Avaliacao.cs
- Mesa.cs
- Pedido.cs
- Prato.cs
- User.cs
- UserConfig.cs

**Resumo dos relacionamentos**

- User e UserConfig (1:1 - Um para Um)
No Código: Um User possui uma única propriedade Config.

No Banco: A tabela T_CF_USER_CONFIG utiliza o ID_USER tanto como Chave Estrangeira (FK) quanto como parte da Chave Primária (PK). Isso garante que cada usuário tenha exatamente uma configuração e vice-versa.

- User e Avaliacao (1:N - Um para Muitos)
No Código: O User tem uma List<Avaliacao>.

No Banco: A tabela T_CF_AVALIACAO possui a FK ID_USER. Um usuário pode deixar várias avaliações, mas cada avaliação pertence a um único autor.

- User e Pedido (1:N - Um para Muitos)
No Código: O Pedido carrega o UserId.

No Banco: Relacionamento clássico onde T_CF_PEDIDO recebe a FK de usuário. Registra quem realizou a compra no restaurante.

- Mesa e Pedido (1:N - Um para Muitos)
No Código: A Mesa tem uma List<Pedido> e o Pedido tem o MesaId.

No Banco: A tabela T_CF_PEDIDO aponta para a T_CF_MESA. Uma mesa pode ter tido vários pedidos ao longo do dia (ou vários pedidos de um mesmo grupo).

- Pedido e Prato (N:N - Muitos para Muitos)
No Código: O Pedido contém uma List<Prato>.

No Banco: É o relacionamento mais complexo. Como um pedido pode ter vários pratos e um prato pode estar em vários pedidos, criamos a tabela intermediária (que no seu diagrama é a ligação entre as duas).

Mecânica: Se você pede 2 Contra-Filés e 1 Suco, a tabela de ligação terá 3 registros apontando para o seu ID_PEDIDO.

*(Extra: Algumas regras de negócio presentes!)*

User: Idade mínima de 13 anos.

Prato: Preço > 0 e tempo de preparo entre 1 e 60 min.

Avaliacao: Pontuação (Score) entre 1 e 5; descrição entre 12 e 100 caracteres.

Mesa: Número não pode ser menor que -1 (considerando que -1 pode ser um código interno para "balcão" ou similar).