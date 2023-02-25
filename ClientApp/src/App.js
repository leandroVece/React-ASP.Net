import React, { Fragment } from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Home from './Component/Home';
import Cadete from './Component/Cadete';
import Pedido from './Component/Pedido';
import Cliente from './Component/Cliente';
import Nav from './Component/Nav';

const App = () => {

  return (
    <Fragment>
      <h1>Proyecto cadeteria con ASP.Net y React.js</h1>
      <BrowserRouter>
        <Nav />
        <Routes>
          <Route path='' element={<Home />} />
          <Route path='/Cadete' element={<Cadete />} >

          </Route>
          <Route path='/Pedido' element={<Pedido />} >

          </Route>
          <Route path='/Cliente' element={<Cliente />} >
          </Route>
        </Routes>
      </BrowserRouter>
    </Fragment>
  )
}
export default App;