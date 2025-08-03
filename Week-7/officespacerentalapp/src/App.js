import React from 'react';
import './App.css';
import Office from './Office';

function App() {
  const element = "Office Space";

  const sr = "https://images.pexels.com/photos/3184291/pexels-photo-3184291.jpeg?auto=compress&cs=tinysrgb&w=800";
  const jsxatt = <img src={sr} width="25%" height="25%" alt="Office Space" />;

  const officeList = [
    {
      Name: "DBS",
      Rent: 50000,
      Address: "Chennai",
      Image: "https://images.pexels.com/photos/323705/pexels-photo-323705.jpeg?auto=compress&cs=tinysrgb&w=800",
    },
    {
      Name: "Skyline",
      Rent: 75000,
      Address: "Mumbai",
      Image: "https://images.pexels.com/photos/380768/pexels-photo-380768.jpeg?auto=compress&cs=tinysrgb&w=800"
    },
    {
      Name: "WorkHub",
      Rent: 58000,
      Address: "Delhi",
      Image: "https://images.pexels.com/photos/37347/office-sitting-room-executive-sitting-room.jpg?auto=compress&cs=tinysrgb&w=800"
    },
    {
      Name: "TechTower",
      Rent: 62000,
      Address: "Hyderabad",
      Image: "https://images.pexels.com/photos/256658/pexels-photo-256658.jpeg?auto=compress&cs=tinysrgb&w=800"
    }
  ];

  return (
    <div className="App">
      <h1>{element} , at Affordable Range</h1>
      {jsxatt}

      {officeList.map((item, index) => {
        return <Office key={index} office={item} />;

})}
    </div>
  );
}

export default App;
