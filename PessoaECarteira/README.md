# Exemplo – Pessoa e Carteira de Motorista (0..1)

## 1. Cenário
Uma **Pessoa** pode ter ou não uma **Carteira de Motorista**.  
Se possuir, a carteira é exclusiva daquela pessoa.  
É possível **atribuir** ou **remover** a carteira, garantindo que os estados sejam consistentes.

---

## 2. Invariantes de Domínio
1. Uma **Pessoa** pode ter **0 ou 1 Carteira de Motorista**.  
2. A **Carteira de Motorista**, se existir, pertence a apenas uma pessoa.  
3. Não é permitido sobrescrever uma carteira existente sem removê-la primeiro.  
4. Métodos de domínio explícitos devem ser usados para **atribuir** (`AssignCarteira`) e **remover** (`RemoveCarteira`).  
5. A carteira deve conter dados válidos (número, validade) quando atribuída.  

---

## 3. Decisões de Navegabilidade
- Navegabilidade mínima:  
  - **Pessoa → CarteiraDeMotorista** (opcional, controlado por métodos de domínio).  
- A **Carteira de Motorista** não mantém referência mutável à pessoa, mantendo baixo acoplamento.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Pessoa {
        -CarteiraMotorista? carteira
        +AssignCarteira(c: CarteiraMotorista): bool
        +RemoveCarteira(): void
    }

    class CarteiraMotorista {
        +string Numero
        +DateTime Validade
    }

    Pessoa "1" --> "0..1" CarteiraMotorista
