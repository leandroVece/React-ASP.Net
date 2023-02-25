import React, { useEffect, useState } from "react";
import { helpHttp } from "../../Helper";
import Form from '../Form';


const InitialForm = {
    id_cliente: null,
    nombre: "",
    direccion: "",
    telefono: "",
    referencia: ""
}


const Cliente = () => {
    const [dbClientes, setDBClientes] = useState([]);
    const [dataToEdit, setDataToEdit] = useState(null);

    const [loading, setLoading] = useState(false);
    const [error, setError] = useState(false);

    let url = "/api/cliente";
    const api = helpHttp();

    useEffect(() => {
        setLoading(true);
        api.get(url).then((res) => {
            if (!res.err) {
                setDBClientes(res);
                setError(null);
            } else {
                setDBClientes(null);
                setError(res);
            }
            setLoading(false);
        });
    }, [url]);

    const createData = (data) => {
        delete data.id_cliente
        let options = {
            body: data,
            headers: { "content-type": "application/json" },
        };
        helpHttp().post(url, options).then((res) => {
            if (res.err) {
                let newData = dbClientes.map((el) => (el.id !== data.id ? data : el));
                setDBClientes(newData);
            } else {
                setError(res);
            }
        })
    }

    const updateData = (data) => {
        let endpoint = `${url}/${data.id_cliente}`;
        console.log(data)

        let options = {
            body: data,
            headers: { "content-type": "application/json" },
        };

        api.put(endpoint, options).then((res) => {
            if (!res.err) {
                let newData = dbClientes.map((el) => (el.id !== data.id ? data : el));
                setDBClientes(newData);
            } else {
                setError(res);
            }
        });
    }


    const deleteData = (id) => {
        let isDelete = window.confirm(
            `¿Estás seguro de eliminar el registro con el id '${id}'?`
        );

        if (isDelete) {
            let endpoint = `${url}/${id}`;
            let options = {
                headers: { "content-type": "application/json" },
            };

            api.del(endpoint, options).then((res) => {
                //console.log(res)
                //console.log(res);
                if (!res.err) {
                    let newData = dbClientes.filter((el) => el.id !== id);
                    setDBClientes(newData);
                } else {
                    console.log(res)
                    setError(res);
                }
            });
        } else {
            return;
        }
    }


    return (
        <>
            <Form
                InitialForm={InitialForm}
                createData={createData}
                updateData={updateData}
                dataToEdit={dataToEdit}
                setDataToEdit={setDataToEdit}
            />

            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Nombre</th>
                        <th>Direccion</th>
                        <th>Telefono</th>
                        <th>Editar</th>
                        <th>Eliminar</th>
                    </tr>
                </thead>
                <tbody>
                    {dbClientes.length > 0 ?
                        (dbClientes.map((data) =>
                            <tr key={data.nombre}>
                                <td>{data.nombre}</td>
                                <td>{data.direccion}</td>
                                <td>{data.telefono}</td>
                                <td>
                                    <button onClick={() => setDataToEdit(data)}>Editar</button>
                                </td>
                                <td>
                                    <button onClick={() => deleteData(data.id_cliente)}>Eliminar</button>
                                </td>
                            </tr>

                        )) : (
                            <tr>
                                <td colSpan="3">Sin datos</td>
                            </tr>
                        )}
                </tbody>
            </table>
        </>
    );
}
export default Cliente;