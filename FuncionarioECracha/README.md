# Exemplo 05 – Funcionário e Crachá (1:1)

## 1. Cenário
Um **Funcionário** ao ser contratado recebe obrigatoriamente um **Crachá**.  
Esse crachá é único e exclusivo daquele funcionário, e a associação não pode ser alterada após a criação.

---

## 2. Invariantes de Domínio
1. Todo **Funcionário** deve possuir um **Crachá** válido.  
2. O **Crachá** deve ser criado junto com o funcionário e não pode ser substituído.  
3. Um **Crachá** pertence a apenas um único funcionário.  
4. O vínculo entre **Funcionário** e **Crachá** é imutável após a construção do objeto.  

---

## 3. Decisões de Navegabilidade
- Navegabilidade mínima:  
  - **Funcionário → Crachá** (obrigatório, definido no construtor).  
- O **Crachá** não mantém referência ao funcionário, garantindo baixo acoplamento.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Funcionario {
        -Cracha cracha
        +Funcionario(nome: string, cracha: Cracha)
        +Cracha Cracha { get }
    }

    class Cracha {
        +string Codigo
        +DateTime DataEmissao
    }

    Funcionario "1" --> "1" Cracha
