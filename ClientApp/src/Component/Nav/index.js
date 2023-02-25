import React from "react";
import { NavLink } from "react-router-dom";

const routes = [
    {
        to: '',
        text: 'Home',
    },
    {
        to: '../Cadete',
        text: 'Cadete',
    },
    {
        to: '../Cliente',
        text: 'Cliente',
    },
    {
        to: '../Pedido',
        text: 'Pedido',
    },
]
function Nav() {

    return (
        <nav>
            <ul>
                {routes.map((route) => (
                    <li key={route.to}>
                        {<NavLink
                            style={({ isActive }) => ({
                                color: isActive ? 'red' : 'blue',
                            })}
                            to={route.to}
                        >
                            {route.text}
                        </NavLink>
                        }
                    </li>
                ))}
            </ul>
        </nav>
    )
}

export default Nav