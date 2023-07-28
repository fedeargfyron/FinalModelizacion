import React from 'react';

const Form = ({ onSubmit, children }) => {

    return (
        <form onSubmit={onSubmit}>
            { children }
            <input className="btn btn-primary" type="submit" />
        </form>);
}

export default Form;