# 🏨 Sistema de Hospedagem

Projeto simples em C# simulando o sistema de hospedagem de um hotel, utilizando conceitos de **Programação Orientada a Objetos**.

## 📚 Descrição

O sistema permite:
- Cadastrar hóspedes e suítes
- Calcular valor total da reserva (com desconto se aplicável)
- Validar a capacidade da suíte
- Obter a quantidade de hóspedes registrados

## 🛠️ Tecnologias Utilizadas

- C# (.NET)
- Programação Orientada a Objetos (POO)
- Console Application

---

## 🧩 Estrutura do Projeto

| Classe   | Responsabilidade |
|----------|------------------|
| `Pessoa` | Representa um hóspede, com nome, sobrenome e telefone |
| `Suite`  | Representa uma suíte, com tipo, capacidade e valor da diária |
| `Reserva`| Gerencia a reserva, incluindo cálculo de diária e verificação da capacidade |

---

## ✅ Funcionalidades

- 📌 Cadastrar suíte
- 📌 Cadastrar hóspedes
- 📌 Verificar capacidade
- 📌 Calcular valor da diária com desconto de 10% para estadias de 10 dias ou mais
- 📌 Listar dados da reserva

---

## ▶️ Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/sistema-hospedagem.git

```
## 📂 Organização do Código

```
📁 App_hotel/
│
├── Models/
│   ├── Pessoa.cs
│   ├── Suite.cs
│   └── Reserva.cs
│
└── Program.cs
```


## 💡 Melhorias Futuras
- Interface gráfica (WPF ou Windows Forms)
- Persistência de dados (banco de dados ou arquivo)
- Cadastro de múltiplas reservas

