

const [form, setForm] = useState(InitialForm);
const { state } = useLocation();

useEffect(() => {
    if (state.dataEdit) {
        //llamar funcion para obtener por id
        setForm(state.dataEdit);
    } else {
        setForm(InitialForm);
    }
}, [state.dataEdit]);

const handleSubmit = (e) => {
    e.preventDefault();

    if (!form.name) {
        alert("Datos incompletos");
        return;
    }

    if (form.id === null) {
        //metodo post(form);
    } else {
        //metodo put(form);
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
};