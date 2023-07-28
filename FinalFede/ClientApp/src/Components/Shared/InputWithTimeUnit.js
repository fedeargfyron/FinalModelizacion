import React from 'react';

const InputWithTimeUnit = ({ register, name, placeholder, errors, requiredTags }) => {
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
            <div className="col-2">
                <select className="form-control" {...register(`${name}TimeUnit`)}>
                    <option value="0">Seconds</option>
                    <option value="1">Minutes</option>
                    <option value="2">Hours</option>
                </select>
            </div>
        </div>
    );
}

export default InputWithTimeUnit;