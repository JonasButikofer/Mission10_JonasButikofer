import { Teams, Bowlers } from "./types/bowler";
import { useEffect, useState } from "react";

function BowlersData() {
  const [bowlers, setBowlers] = useState<Bowlers[]>([]);

  useEffect(() => {
    fetch("https://localhost:4000/api/Bowlers/GetBowlerData")
      .then((response) => {
        console.log("Response status:", response.status);
        if (!response.ok) {
          throw new Error("Network response was not ok");
        }
        return response.json();
      })
      .then((data) => {
        console.log("Fetched data:", data); // Log the data for debugging
        // If your API wraps the data, adjust here. For instance, if it returns { data: [...] }
        setBowlers(data);
      })
      .catch((error) => console.error("Error fetching bowlers:", error));
  }, []);
  

  return (
    <>
      <h1>Bowling Data!</h1>
      <table>
        <thead>
          <tr>
            <th>Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map((f) => (
            <tr key={f.bowlerID}>
              <td>
                {f.bowlerFirstName} {f.bowlerMiddleInit} {f.bowlerLastName}
              </td>
              <td>{f.team ? f.team.teamName : "N/A"}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlersData;
