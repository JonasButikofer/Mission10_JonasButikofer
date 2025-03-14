import React from 'react';
import ReactDOM from 'react-dom/client';
import BowlersData from './BowlerData'; // Adjust the path if needed

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <React.StrictMode>
    <BowlersData />
  </React.StrictMode>
);

