import React, { useState, useEffect } from "react"
import { useLocation } from "react-router-dom";
import Input from "./Input";


const FormApi = ({ InitialForm, createData, updateData, dataToEdit, setDataToEdit }) => {
    const [form, setForm] = useState(InitialForm);
    const { state } = useLocation();
    const [error, setError] = useState(false);
    const [array, setArray] = useState(Object.getOwnPropertyNames(form));

    useEffect(() => {
        if (dataToEdit) {
            //llamar funcion para obtener por id
            setForm(dataToEdit);
        } else {
            setForm(InitialForm);
        }
    }, [dataToEdit]);

    //me equivoque y no envie el objeto que tenia que cambiar
    const handleSubmit = (e) => {
        e.preventDefault();

        if (form.id_cliente === null) {
            createData(form)
        } else {
            updateData(form);
        }
        handleReset();
    };


    const handleChange = (e) => {
        setForm({
            ...form,
            [e.target.name]: e.target.value,
        });
    };

    const handleReset = () => {
        setForm(InitialForm);
        setDataToEdit(null);
    };

    return (
        <>
            <h3>Formulario</h3>
            <div className="w-75 mx-auto mt-2">
                <form className=" mx-auto" onSubmit={handleSubmit}>

                    <div className="row g-4">
                        {array.map((d, index) => {
                            if (d != 'id_cliente') {
                                return (
                                    <div className="d-block" key={`field-${index}`}>
                                        <label className="me-2">{d}</label>
                                        <Input
                                            placeholder={d}
                                            name={d}
                                            value={form[d]}
                                            handleChange={handleChange}
                                        />
                                    </div>
                                );
                            }
                        })}
                        <div className="col-auto ">
                            <input type="submit" value="Enviar" />
                            <input type="reset" value="Limpiar" onClick={handleReset} />
                        </div>
                    </div>
                </form>
            </div>
        </>
    )
}

export default FormApi;

