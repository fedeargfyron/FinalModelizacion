import React from 'react';
import MetricsDescriptions from './MetricsDescriptions';

const MetricsTable = ({ metrics }) => {
    return (<table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
            <tr>
                <th>Metric</th>
                <th>Value</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody>
            {Object.keys(metrics).map((metric, i) => {
                let capitalizedMetric = metric.charAt(0).toUpperCase() + metric.slice(1);
                let metricValue = metrics[metric];
                let formattedMetricValue = typeof metricValue === "number" ? (Math.round(metricValue * 100) / 100).toFixed(2) : metricValue;
                return <tr key={metric}>
                    <td>{capitalizedMetric}</td>
                    <td>{formattedMetricValue}</td>
                    <td>{MetricsDescriptions[capitalizedMetric]}</td>
                </tr>
            })}
        </tbody>
    </table>);
}

export default MetricsTable;