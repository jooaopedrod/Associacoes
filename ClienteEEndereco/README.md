# Exemplo 06 – Cliente e Endereço de Entrega Preferencial (0..1)

## 1. Cenário
Um **Cliente** pode ter ou não um **Endereço de Entrega Preferencial**.  
Esse endereço, se existir, é exclusivo do cliente e pode ser alterado ou removido conforme necessário.

---

## 2. Invariantes de Domínio
1. Um **Cliente** pode ter **0 ou 1 Endereço Preferencial**.  
2. O **Endereço Preferencial**, se definido, pertence apenas a um cliente.  
3. Não é permitido sobrescrever silenciosamente o endereço já cadastrado.  
4. O cliente deve possuir métodos explícitos para **definir**, **alterar** e **remover** o endereço.  

---

## 3. Decisões de Navegabilidade
- Navegabilidade mínima:  
  - **Cliente → Endereco** (opcional, controlado pelos métodos `SetEnderecoPreferencial` e `RemoveEnderecoPreferencial`).  
- O **Endereço** não mantém referência ao cliente, garantindo baixo acoplamento.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Cliente {
        -Endereco? enderecoPreferencial
        +SetEnderecoPreferencial(e: Endereco): bool
        +RemoveEnderecoPreferencial(): void
    }

    class Endereco {
        +string Rua
        +string Cidade
        +string CEP
    }

    Cliente "1" --> "0..1" Endereco
