# Exemplo 09 – Computador e Placa de Vídeo Dedicada (0..1)

## 1. Cenário
Um **Computador** pode ou não ter uma **Placa de Vídeo Dedicada** instalada.  
A placa, se presente, pertence exclusivamente ao computador. É possível instalar ou desinstalar a placa, garantindo consistência.

---

## 2. Invariantes de Domínio
1. Um **Computador** pode ter **0 ou 1 Placa de Vídeo Dedicada**.  
2. Uma **Placa de Vídeo** só pode pertencer a um computador por vez.  
3. Não é permitido sobrescrever silenciosamente uma placa já instalada.  
4. Deve existir método explícito para **instalar** (`InstallGPU`) e **desinstalar** (`RemoveGPU`).  
5. A instalação deve validar compatibilidade mínima (ex.: memória, slots disponíveis).  

---

## 3. Decisões de Navegabilidade
- Navegabilidade mínima:  
  - **Computador → PlacaVideoDedicada** (opcional, controlado por métodos de domínio).  
- A **Placa de Vídeo** não mantém referência ao computador, evitando acoplamento desnecessário.  

---

## 4. Diagrama Mínimo (UML)

```mermaid
classDiagram
    class Computador {
        -PlacaVideoDedicada? placa
        +InstallGPU(p: PlacaVideoDedicada): bool
        +RemoveGPU(): void
    }

    class PlacaVideoDedicada {
        +string Modelo
        +int MemoriaGB
    }

    Computador "1" --> "0..1" PlacaVideoDedicada
