#!/bin/bash

sleep_time=15

echo "Waiting $sleep_time seconds to run sql setup script..."

sleep $sleep_time

echo "Running sql setup script..."

/opt/mssql-tools/bin/sqlcmd -S 0.0.0.0 -U SA -P $SA_PASSWORD -i ./setup.sql
