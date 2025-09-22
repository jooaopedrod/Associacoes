# Exemplo 04 – Livro, Capa (1:1) e Produto, Descrição Detalhada (0..1)

## 1. Cenário
Um **Livro** deve sempre possuir uma **Capa** exclusiva, definida no momento de sua criação (1:1 obrigatório).  
Já um **Produto** pode ter ou não uma **Descrição Detalhada**, que é exclusiva daquele produto e pode ser adicionada ou removida após a criação (0..1 opcional).

---

## 2. Invariantes de Domínio
### Livro – Capa (1:1)
1. Um **Livro** deve sempre ter uma **Capa** válida.  
2. A **Capa** é obrigatória no construtor e não pode ser alterada.  
3. Uma **Capa** só pode pertencer a um único livro.  

### Produto – Descrição Detalhada (0..1)
1. Um **Produto** pode ter **0 ou 1 Descrição Detalhada**.  
2. A **Descrição Detalhada**, se presente, pertence apenas a um produto.  
3. Não é permitido sobrescrever silenciosamente uma descrição já associada.  
4. Deve existir método explícito para adicionar (`AssignDescription`) e remover (`RemoveDescription`).  

---

## 3. Decisões de Navegabilidade
- **Livro → Capa**: obrigatória, criada junto, imutável.  
- **Produto → DescricaoDetalhada**: opcional, controlada por métodos de domínio.  
- A **Capa** e a **Descrição Detalhada** não conhecem seus agregadores, mantendo baixo acoplamento.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Livro {
        -Capa capa
        +Livro(titulo: string, capa: Capa)
        +Capa Capa { get }
    }

    class Capa {
        +string Estilo
        +string Cor
    }

    class Produto {
        -DescricaoDetalhada? descricao
        +AssignDescription(d: DescricaoDetalhada): bool
        +RemoveDescription(): void
    }

    class DescricaoDetalhada {
        +string Texto
        +string Idioma
    }

    Livro "1" --> "1" Capa
    Produto "1" --> "0..1" DescricaoDetalhada
