﻿using Model.BL;

namespace Presenter
{
    public class MainPresenter
    {
        private IMainModel _model;
        private IMainView _view;
        public MainPresenter(IMainModel model, IMainView view)
        {
            _model = model;
            _model.EventAddEmployee += _model_EventAddEmployee;
            _model.EventDelEmployee += _model_EventDelEmployee;

            _view = view;
            _view.EventLoadView += _view_EventLoadView;
            _view.EventAddEmployee += _view_EventAddEmployee;
            _view.EventDelEmployee += _view_EventDelEmployee;
        }

        private void _view_EventAddEmployee(object? sender, EmployeeEventArgs e)
        {
            _model.AddEmployee(e.Employee);
        }

        private void _view_EventDelEmployee(object? sender, EmployeeEventArgs e)
        {
            _model.DeleteEmployee(e.Employee);
        }

        private void _view_EventLoadView(object? sender, EventArgs e)
        {
            _view.LoadList(_model.GetEmployees());
        }

        private void _model_EventAddEmployee(object? sender, EmployeeEventArgs e)
        {
            _view.Add(e.Employee);
        }

        private void _model_EventDelEmployee(object? sender, EmployeeEventArgs e)
        {
            _view.Delete(e.Employee);
        }
    }
}
