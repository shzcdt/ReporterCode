﻿namespace ReporterCode;

public interface IEmployeeReportBuilder
{
    void BuildHeader();

    void BuildBody();

    void BuildFooter();

    EmployeeReport GetReport();
}