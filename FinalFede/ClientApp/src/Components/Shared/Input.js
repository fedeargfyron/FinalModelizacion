import React from 'react';

const Input = ({ register, name, placeholder, errors, requiredTags }) => {
    let value = `${name}Value`;
    return (
        <div className="form-group row pb-2">
            <div className="col-4">
                <input
                    type="number"
                    placeholder={`${placeholder ? placeholder : name} value`}
                    className="form-control"
                    {...register(value, requiredTags)}
                ></input>
                {errors?.[value] ? <p className="text-danger mb-0">{errors[value].message}</p> : <></>}
            </div>
        </div>
    );
}

export default Input;