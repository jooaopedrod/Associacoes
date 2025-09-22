# Exemplo 01 – Carro e Motor (1:1)

## 1. Cenário

Um **Carro** sempre possui exatamente um **Motor**, e cada motor pertence a apenas um carro.  
Não é possível criar um carro sem motor, e a associação é imutável após a criação.

---

## 2. Invariantes de Domínio

1. Todo **Carro** deve ter um **Motor** obrigatoriamente.
2. Um **Motor** só pode pertencer a um único **Carro**.
3. O motor é definido no momento da criação do carro e **não pode ser substituído**.
4. Nenhum dos dois pode ser nulo.

---

## 3. Decisões de Navegabilidade

- A classe **Carro** mantém referência obrigatória para seu **Motor**.
- Navegabilidade mínima: `Carro → Motor`.
- O **Motor** conhece o **Carro** apenas no momento da associação (opcional), para reforçar a exclusividade.

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Carro {
        -Motor motor
        +Carro(motor: Motor)
        +Motor Motor { get }
    }

    class Motor {
        +string NumeroSerie
    }

    Carro "1" --> "1" Motor
```
