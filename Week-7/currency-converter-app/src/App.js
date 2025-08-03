import React, { useState } from "react";

function App() {
  const [count, setCount] = useState(1);
  const [amount, setAmount] = useState("");
  const [currency, setCurrency] = useState("Euro");

  const handleIncrement = () => {
    setCount(count + 1);
    sayHello();
  };

  const handleDecrement = () => {
    setCount(count - 1);
  };

  const sayHello = () => {
    alert("Hello! This is a static message.");
  };

  const sayWelcome = (msg) => {
    alert(msg);
  };

  const handleClick = () => {
    alert("I was clicked");
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const rate = 80;
    const converted = amount * rate;
    alert(`Converting to  ${currency} Amount is ${converted}`);
  };

  return (
    <div style={{ padding: "30px", fontFamily: "Arial" }}>
      <div>
        <p>{count}</p>
        <button onClick={handleIncrement}>Increment</button>
        <br />
        <button onClick={handleDecrement}>Decrement</button>
        <br /><br />
        <button onClick={() => sayWelcome("Welcome")}>Say welcome</button>
        <br /><br />
        <button onClick={handleClick}>Click on me</button>
      </div>

      <br /><br />

      <h2 style={{ color: "green", fontWeight: "bold" }}>Currency Convertor!!!</h2>

      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: "10px" }}>
          <label>
            Amount:&nbsp;
            <input
              type="number"
              value={amount}
              onChange={(e) => setAmount(e.target.value)}
              style={{ width: "80px" }}
            />
          </label>
        </div>
        <div style={{ marginBottom: "10px" }}>
          <label>
            Currency:&nbsp;
            <select
              value={currency}
              onChange={(e) => setCurrency(e.target.value)}
              style={{ width: "100px" }}
            >
              <option value="Euro">Euro</option>
            </select>
          </label>
        </div>
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default App;
