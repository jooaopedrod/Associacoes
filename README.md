# Atividade de Modelagem de Associações 0..1 e 1:1 em C#

## 1. Objetivo da Atividade

Implementar associações entre classes em C# cobrindo:

- **0..1 (opcional)** – o dependente pode ou não existir;
- **1:1 (obrigatório)** – o dependente é obrigatório e exclusivo.

A implementação deve garantir:

- **Invariantes de domínio** por design;
- **Validação na fronteira** via métodos de domínio;
- **Navegabilidade mínima** e baixo acoplamento;
- Uso correto de **propriedades anuláveis** e **imutabilidade** quando necessário.

## 2. Invariantes de Domínio Gerais

1. **Associações 1:1** são obrigatórias e imutáveis após a criação.
2. **Associações 0..1** são opcionais, mas mantêm consistência via métodos de domínio (`Assign`, `Remove`).
3. Nenhuma associação obrigatória pode ser nula.
4. Cada dependente só pertence a uma instância da classe principal por vez (exclusividade).
5. Operações de atribuição devem **validar regras de negócio** e impedir sobrescrita silenciosa.

---

## 3. Decisões de Navegabilidade

- Navegabilidade mínima: todas as classes principais conhecem seus dependentes.
- Dependentes opcionais ou obrigatórios não mantêm referências mutáveis ao principal, evitando acoplamento desnecessário.
- Métodos de domínio (`Assign`, `Unassign`, `Remove`) são utilizados para gerenciar associações 0..1.

---
