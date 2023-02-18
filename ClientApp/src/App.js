import React, { useEffect, useState } from 'react';
import './custom.css';

const App = () => {

  const [dbCadetes, setDBCadete] = useState([]);
  let url = "/api/cadete/lista";

  const ListaCadete = async () => {

    const response = await fetch(url);
    if (response.ok) {
      const data = await response.json();
      console.log(data)
      setDBCadete(data);
    } else {
      console.log("error inesperado try");
    }

  }


  useEffect(() => {
    ListaCadete();
  }, [])

  return (
    <div>
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Nombre</th>
            <th>Direccion</th>
            <th>Telefono</th>
          </tr>
        </thead>
        <tbody>
          {dbCadetes.length > 0 ?
            (dbCadetes.map((data) =>
              <tr key={data.nombre}>
                <td>{data.nombre}</td>
                <td>{data.direccion}</td>
                <td>{data.telefono}</td>
              </tr>
            )) : (
              <tr>
                <td colSpan="3">Sin datos</td>
              </tr>
            )}
        </tbody>
      </table>
    </div>
  );
}
export default App;