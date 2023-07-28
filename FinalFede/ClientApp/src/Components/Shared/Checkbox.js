import React from 'react';

const Checkbox = ({ register, name, placeholder }) => {
    return (
        <div className="form-group row pb-2">
            <div className="col-4">
                <div className="form-check">
                    <input {...register(`${name}Value`)} className="form-check-input" type="checkbox" value="" id={`${name}check`} />
                    <label className="form-check-label" htmlFor={`${name}check`}>
                        { placeholder }
                    </label>
                </div>
            </div>
        </div>
    );
}

export default Checkbox;