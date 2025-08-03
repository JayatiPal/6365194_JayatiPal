import React from 'react';

const ListofPlayers = () => {
  const players = [
    { name: 'Virat Kohli', score: 89 },
    { name: 'Rohit Sharma', score: 95 },
    { name: 'Shubman Gill', score: 67 },
    { name: 'Rishabh Pant', score: 45 },
    { name: 'KL Rahul', score: 72 },
    { name: 'Hardik Pandya', score: 66 },
    { name: 'Jasprit Bumrah', score: 50 },
    { name: 'Ravindra Jadeja', score: 91 },
    { name: 'Yuzvendra Chahal', score: 30 },
    { name: 'Shreyas Iyer', score: 81 },
    { name: 'Mohammed Shami', score: 76 }
  ];

  const players70 = [];

  players.map((item) => {
    if (item.score <= 70) {
      players70.push(item);
    }
  });

  return (
    <div>
      {players.map((item) => {
        return (
          <div>
            <li>Mr. {item.name}<span> - {item.score} </span></li>
          </div>
        );
      })}

      <hr />

      <h3>Players with score below 70</h3>
      {players70.map((item) => {
        return (
          <div>
            <li>Mr. {item.name}<span> - {item.score} </span></li>
          </div>
        );
      })}
    </div>
  );
};

export default ListofPlayers;
