# Exemplo 10 – Usuário e Dados Biométricos (1:1)

## 1. Cenário
Todo **Usuário** deve possuir obrigatoriamente **Dados Biométricos** para autenticação.  
Cada conjunto de dados biométricos pertence exclusivamente a um usuário, e a associação não pode ser alterada após a criação.

---

## 2. Invariantes de Domínio
1. Um **Usuário** deve sempre ter exatamente **um conjunto de Dados Biométricos**.  
2. Os **Dados Biométricos** pertencem a apenas um usuário.  
3. A associação entre **Usuário** e **Dados Biométricos** é **imutável** após a criação.  
4. Nenhum dos campos dos dados biométricos pode ser nulo ou vazio.  

---

## 3. Decisões de Navegabilidade
- Navegabilidade mínima:  
  - **Usuário → DadosBiometricos** (obrigatório, definido no construtor).  
- Os **Dados Biométricos** não mantêm referência mutável a outros objetos, garantindo baixo acoplamento.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Usuario {
        -DadosBiometricos dados
        +Usuario(nome: string, impressaoDigital: string, reconhecimentoFacial: string)
        +DadosBiometricos Dados { get }
    }

    class DadosBiometricos {
        +string ImpressaoDigital
        +string ReconhecimentoFacial
    }

    Usuario "1" --> "1" DadosBiometricos
