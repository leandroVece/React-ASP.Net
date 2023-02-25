const Input = ({ placeholder, name, value, handleChange }) => {

    return (
        <input
            placeholder={placeholder}
            name={name}
            value={value || ''}
            onChange={(event) => handleChange(event)}
        />
    )
}

export default Input