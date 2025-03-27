import { useEffect, useState } from 'react';

interface Team {
  teamName: string;
}

interface Bowler {
  bowlerID: number;
  bowlerFirstName: string;
  bowlerMiddleInit?: string;
  bowlerLastName: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  team: Team;
}

function BowlerTable() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    fetch('http://localhost:5230/api/bowlers')
      .then((res) => res.json())
      .then((data) => setBowlers(data));
  }, []);

  return (
    <div style={{ padding: '1rem' }}>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((b) => (
            <tr key={b.bowlerID}>
              <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit ?? ''} ${b.bowlerLastName}`}</td>
              <td>{b.team?.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerTable;