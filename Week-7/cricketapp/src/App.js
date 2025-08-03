import React from 'react';
import ListofPlayers from './ListofPlayers';
import IndianPlayersComponent, { IndianPlayers, OddPlayers, EvenPlayers } from './IndianPlayers';

// Set flag to switch views
var flag = false;

function App() {
  if (flag === true) {
    return (
      <div>
        <h1> List of Players</h1>
        <ListofPlayers />
      </div>
    );
  } else {
    return (
      <div>
        <div>
          <h1> Indian Team </h1>
          <h1> Odd Players </h1>
          {OddPlayers(IndianPlayers)}
          <hr />
          <h1> Even Players</h1>
          {EvenPlayers(IndianPlayers)}
        </div>
        <hr />
        <div>
          <h1> List of Indian Players Merged:</h1>
          <IndianPlayersComponent />
        </div>
      </div>
    );
  }
}

export default App;
